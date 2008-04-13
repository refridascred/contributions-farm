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

        /// <summary>Compare every pair of record readings.</summary>
        public static long OverlapRecordCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
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
