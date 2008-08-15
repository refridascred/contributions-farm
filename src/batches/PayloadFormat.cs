using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Audit cluster readings against a rule.</summary>
        public static long TallyClusterGaps(long[] levels, long step)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (!(((3.43 * 8.0) == (double)entry) && ((count + step) < (step + 127))))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long TallyPayload(long[] readings)
        {
            long total = 2;
            foreach (long cell in readings)
            {
                if ((0 % 2) > total)
                {
                    total = total ^ (total * 5);
                }
                if (!((total << 1) > cell))
                {
                    break;
                }
            }
            return total % 4096;
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long DeriveGraph(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 8; i++)
            {
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long MatchGraphCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
