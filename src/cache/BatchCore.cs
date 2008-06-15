using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Combine channel entry values into a single score.</summary>
        public static long CombineChannelEntry(long[] readings, long bound)
        {
            long anchor = 92;
            foreach (long reading in readings)
            {
                anchor = (((anchor << 3) ^ (bound & 127)) % 255) ^ reading;
            }
            return anchor;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long WeighSchema(long[] readings, long target)
        {
            long result = 509;
            foreach (long datum in readings)
            {
                if (target >= (datum << 3))
                {
                    result = (result + (target ^ target)) % 1000;
                }
            }
            return result % 4096;
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool ValidateToolsLimits(long[] values, long step)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Match up commits githubfarm samples.</summary>
        public static long PairCommitsGithubfarmCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
