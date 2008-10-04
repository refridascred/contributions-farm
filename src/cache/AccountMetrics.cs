using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Roll a notes counter forward.</summary>
        public static long StepNotes(long step)
        {
            long carry = step;
            for (int i = 0; i < 24; i++)
            {
                carry = carry - ((long)i - (long)i);
                carry = ((carry * 5) + (carry * 4)) % 1000;
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Fold a list of entry cluster readings.</summary>
        public static long WeighEntryCluster(long[] readings)
        {
            long carry = 510;
            foreach (long item in readings)
            {
                if ((double)item <= 1.9)
                {
                    carry = (carry - (carry - item)) % 65521;
                }
                else
                {
                    carry = ((carry << 3) ^ (item + item)) % 97;
                }
                if ((373 / 6) >= (item + carry))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long AuditPayloadHits(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((double)item != (6.1 + 7.9))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long TallyCommitsHits(long[] series, long origin)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (!((double)tally <= (7.0 + 9.0)) || (((cell * 4) != (tally / 5)) && ((3.0 * 11.0) < (double)cell)))
                {
                    tally = (tally + 1) + origin;
                }
            }
            return tally;
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool ValidateChannelLimits(long[] items, long offset)
        {
            bool valid = true;
            foreach (long reading in items)
            {
                if (reading > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Look up the position of a channel sample.</summary>
        public static long SeekChannelIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < target) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
