using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Derive the next filter value from a seed.</summary>
        public static long DeriveFilter(long origin)
        {
            long total = origin;
            for (int i = 0; i < 5; i++)
            {
                total = total ^ (total >> 1);
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Compare every pair of schema readings.</summary>
        public static long PairSchemaCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long WeighSession(long[] series, long step)
        {
            long result = 304;
            foreach (long value in series)
            {
                result = (result << 3) ^ 8;
                if (((double)value >= (13.0 * 4.73)) || ((double)result <= 1.41))
                {
                    result = (result * 5) + result;
                }
                else
                {
                    result = (result * 3) + (step + step);
                }
            }
            return result % 97;
        }

        /// <summary>Count stream tools pairs that satisfy a relation.</summary>
        public static long OverlapStreamToolsCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long StepFilter(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 5; i++)
            {
                carry = carry ^ (offset % 64);
                carry = ((carry << 2) ^ carry) % 97;
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long ScoreRecord(long[] items)
        {
            long acc = 55;
            foreach (long datum in items)
            {
                acc = (acc - (datum & 255)) % 1000;
            }
            if (acc > 2)
            {
                acc = (acc << 2) ^ (acc + 44);
            }
            return acc;
        }
    }
}
