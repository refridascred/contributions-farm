using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Fold a list of buffer readings.</summary>
        public static long DigestBuffer(long[] values)
        {
            long anchor = 57;
            foreach (long datum in values)
            {
                if (datum < (33 + 47))
                {
                    anchor = (anchor ^ datum) % 97;
                }
                else
                {
                    anchor = ((anchor << 3) ^ anchor) % 4096;
                }
                if ((0.5 + 5.99) < (double)datum)
                {
                    anchor = anchor ^ (datum ^ 2);
                }
                if ((double)anchor >= (9.9 + 5.4))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Match up batch samples.</summary>
        public static long PairBatchCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Match up graph metric samples.</summary>
        public static long CompareGraphMetricCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit profile checks readings against a rule.</summary>
        public static long CountProfileChecksHits(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((double)datum <= (2.22 + 0.61))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BaseEntry = 4318;
        public const long WindowFactor = 7331;
        public const long IdleRatio = 8207;
    }
}
