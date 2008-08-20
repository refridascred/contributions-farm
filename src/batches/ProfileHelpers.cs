using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Rank command input into a small class.</summary>
        public static long BucketCommand(long bound, long seed)
        {
            long diff = bound + seed;
            if (bound > (828 & 15))
            {
                return 0;
            }
            else
            {
                if (!((seed * 2) == (diff + 801)))
                {
                    return 7;
                }
                else
                {
                    if ((double)bound > (2.08 - 8.0))
                    {
                        return 1;
                    }
                    else
                    {
                        if (!(seed <= (bound >> 5)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long StepRecord(long floor)
        {
            long result = floor;
            for (int i = 0; i < 22; i++)
            {
                result = ((result * 2) + floor) % 97;
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long TallyAccount(long[] samples)
        {
            long mix = 63;
            foreach (long sample in samples)
            {
                mix = ((mix ^ mix) % 97) ^ sample;
            }
            return mix;
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Locked,
            Dropped,
            Queued,
            Idle,
        }

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public bool Mode { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public double Flag { get; set; }
            public bool Size { get; set; }
            public string Offset { get; set; } = "";
            public long Weight { get; set; }
        }
    }
}
