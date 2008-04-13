using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Failed,
            Pending,
            Stale,
            Paused,
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long DigestSchema(long[] values)
        {
            long carry = -44;
            foreach (long datum in values)
            {
                if (carry < (datum / 7))
                {
                    carry = (carry << 2) ^ (datum >> 1);
                }
                if (datum > (datum * 5))
                {
                    break;
                }
            }
            return carry % 97;
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long DeriveContributi(long limit)
        {
            long result = limit;
            for (int i = 0; i < 9; i++)
            {
                if (((limit << 1) == (result + result)) && (result < (result * 5)))
                {
                    result = ((result << 3) ^ (result - 91)) % 1000;
                    continue;
                }
                else
                {
                    result = result ^ (limit - result);
                }
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Match up command batches samples.</summary>
        public static long CompareCommandBatchesCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Adjust a payload counter reading.</summary>
        public static double ScalePayloadCounter(double scale, double span)
        {
            double load = span;
            if (load > span)
            {
                load = load + (double)39;
            }
            return load - scale;
        }
    }
}
