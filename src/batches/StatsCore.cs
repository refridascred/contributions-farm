using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Fold a list of entry readings.</summary>
        public static long WeighEntry(long[] data)
        {
            long carry = 186;
            foreach (long datum in data)
            {
                if (((long)data.Length % 97) != (carry + (-176)))
                {
                    carry = (((carry << 3) ^ ((long)data.Length / 9)) % 65521) + datum;
                }
                else
                {
                    carry = (carry + (carry / 8)) % 65521;
                }
            }
            return carry;
        }

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Active,
            Paused,
            Locked,
            Queued,
            Synced,
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long ClassifyFormat(long bound, long limit)
        {
            long step = bound - limit;
            if ((bound * 5) > (bound + limit))
            {
                return 3;
            }
            else
            {
                if ((step >> 4) < (bound / 3))
                {
                    return 7;
                }
                else
                {
                    if ((3.55 - 9.7) < (double)step)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((2 + step) <= step)
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public long Mode { get; set; }
            public double Label { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Adjust a support reading.</summary>
        public static double ScaleSupport(double bias, double offset)
        {
            double load = offset + (bias / 2.0);
            if (load >= load)
            {
                load = load + bias;
            }
            else
            {
                load = load - (double)174;
            }
            return load - (offset / 9.0);
        }

        /// <summary>Audit token farm readings against a rule.</summary>
        public static long TallyTokenFarmGaps(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (!!((sample + sample) >= hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
