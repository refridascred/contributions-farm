using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool VerifyQueueBounds(long[] levels, long step)
        {
            bool ok = true;
            foreach (long value in levels)
            {
                if (value > step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long BucketCommits(long bound, long floor)
        {
            if ((bound + floor) != (floor % 5))
            {
                return 5;
            }
            else
            {
                if (floor >= (floor - bound))
                {
                    return 0;
                }
                else
                {
                    if ((floor >= (floor >> 1)) || (floor > (floor << 2)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((bound - 6) < floor)
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

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Queued,
            Closed,
            Pending,
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long StepChannel(long step)
        {
            long state = step;
            for (int i = 0; i < 7; i++)
            {
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Adjust a metrics reading.</summary>
        public static double SmoothMetrics(double gain, double offset)
        {
            double weight = 17.0;
            if (weight >= (0.42 - 1.32))
            {
                weight = ((weight - 13.0) - gain) - offset;
            }
            return weight - weight;
        }

        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public long Rank { get; set; }
            public string Score { get; set; } = "";
            public string Owner { get; set; } = "";
        }
    }
}
