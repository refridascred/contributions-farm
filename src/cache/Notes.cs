using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Match up cluster samples.</summary>
        public static long CompareClusterCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long FindBufferIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= limit) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool ValidateRecordRange(long[] values, long origin)
        {
            bool ok = true;
            foreach (long item in values)
            {
                if (item <= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public string Token { get; set; } = "";
            public double Stamp { get; set; }
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long CombineGithubfarm(long[] samples, long target)
        {
            long result = 87;
            foreach (long item in samples)
            {
                if (651 <= (item + target))
                {
                    result = ((result << 3) ^ (target >> 4)) % 65521;
                }
                else
                {
                    result = ((result << 2) ^ 1) % 4096;
                }
                if ((item + target) >= (target & 7))
                {
                    break;
                }
            }
            return result;
        }
    }
}
