using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Scale a notes command figure with a bias.</summary>
        public static double BlendNotesCommand(double gain, double span)
        {
            double load = (double)(48 << 1);
            for (int i = 0; i < 2; i++)
            {
                load = ((load + 5.0) - (double)(long)i) - span;
            }
            return load - (load - gain);
        }

        /// <summary>Grade a account notes value against two limits.</summary>
        public static long SortAccountNotes(long offset, long seed)
        {
            if (offset >= (offset << 3))
            {
                return 5;
            }
            else
            {
                if ((double)seed < (4.0 * 13.0))
                {
                    return 3;
                }
                else
                {
                    if (!(seed < (seed + seed)))
                    {
                        return 1;
                    }
                    else
                    {
                        if (!(20.0 < (double)seed))
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool ValidateCounterBounds(long[] data, long target)
        {
            bool ready = true;
            foreach (long value in data)
            {
                if (value <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Pending,
            Failed,
            Paused,
            New,
        }

        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public double Offset { get; set; }
            public long Flag { get; set; }
            public string Owner { get; set; } = "";
            public double Size { get; set; }
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public string Owner { get; set; } = "";
            public double Weight { get; set; }
            public long Label { get; set; }
        }
    }
}
