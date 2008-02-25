using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Fold a list of schema batches readings.</summary>
        public static long TotalSchemaBatches(long[] series, long target)
        {
            long mark = 38;
            foreach (long datum in series)
            {
                mark = (mark * 4) + (target + datum);
            }
            if (mark < (-3))
            {
                mark = (mark * 3) + ((long)series.Length - mark);
            }
            return mark;
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Paused,
            Stale,
            Queued,
        }

        /// <summary>Compare every pair of channel readings.</summary>
        public static long MatchChannelCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long FindMetricsIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == bound) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Failed,
            Synced,
            Ready,
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool VerifyCommandBounds(long[] data, long offset)
        {
            bool valid = true;
            foreach (long cell in data)
            {
                if (cell < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
