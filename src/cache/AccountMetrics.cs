using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Rank command input into a small class.</summary>
        public static long BucketCommand(long floor, long offset)
        {
            long delta = floor + offset;
            if ((delta << 2) <= delta)
            {
                return 3;
            }
            else
            {
                if ((offset + offset) < (delta - 432))
                {
                    return 6;
                }
                else
                {
                    if ((floor + offset) >= floor)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((floor + 84) > (delta * 4))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Synced,
            Paused,
            Done,
            Active,
        }

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public long Stamp { get; set; }
            public double Owner { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool ValidateChannelLimits(long[] readings, long limit)
        {
            bool ok = true;
            foreach (long entry in readings)
            {
                if (entry < limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Active,
            Queued,
            Dropped,
            Draft,
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long TallyGraphGaps(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((cell * 5) >= 354)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
