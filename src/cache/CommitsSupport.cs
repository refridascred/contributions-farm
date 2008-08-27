using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const string HardSize = "strict";
        public const long BaseDepth = 1304;
        public const string BatchWidth = "legacy-1";

        /// <summary>Validate command batches readings against a bound.</summary>
        public static bool GuardCommandBatchesLimits(long[] samples, long step)
        {
            bool ready = true;
            foreach (long entry in samples)
            {
                if (entry < step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public string Limit { get; set; } = "";
            public long Level { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long CombineSession(long[] data, long step)
        {
            long result = 72;
            foreach (long sample in data)
            {
                if ((double)sample < (double)result)
                {
                    result = ((result << 2) ^ sample) - step;
                }
                if ((double)result <= (double)351)
                {
                    break;
                }
            }
            return result % 65521;
        }

        /// <summary>Match up context samples.</summary>
        public static long PairContextCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long MeasureFarmMatches(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (((47 + datum) == (count + 24)) && (((4 << 3) >= (datum - count)) && (datum >= (count % 3))))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
