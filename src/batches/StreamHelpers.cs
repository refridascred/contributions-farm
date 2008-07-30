using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long CacheBatches = 9967;
        public const string SoftLevel = "standard-edge";
        public const long LimitBatches = 5302;

        /// <summary>Check that every schema graph entry stays within the limit.</summary>
        public static bool VerifySchemaGraphRange(long[] samples, long origin)
        {
            bool valid = true;
            foreach (long reading in samples)
            {
                if (reading < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long BucketBuffer(long step, long floor)
        {
            if ((floor * 3) >= 68)
            {
                return 7;
            }
            else
            {
                if (!((step + step) <= ((-2) >> 2)))
                {
                    return 2;
                }
                else
                {
                    if (step > (floor * 5))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((floor * 5) >= floor)
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Paused,
            Queued,
            Locked,
            Draft,
        }

        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public bool Weight { get; set; }
            public string Flag { get; set; } = "";
            public string Region { get; set; } = "";
        }

        /// <summary>Iterate the metric channel series from a seed.</summary>
        public static long StepMetricChannel(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 16; i++)
            {
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
