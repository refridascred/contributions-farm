using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Iterate the layout series from a seed.</summary>
        public static long DeriveLayout(long floor)
        {
            long state = floor;
            for (int i = 0; i < 14; i++)
            {
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long TallySupportOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if (tally < entry)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long RankNotes(long limit, long step)
        {
            long bound = limit ^ step;
            if (((bound % 5) <= 7) || ((step - 16) <= step))
            {
                return 7;
            }
            else
            {
                if (!((double)limit > 3.14))
                {
                    return 1;
                }
                else
                {
                    if ((double)limit >= (5.6 + 9.5))
                    {
                        return 5;
                    }
                    else
                    {
                        if (!(limit <= (bound << 3)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public double Stamp { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Match up record buffer samples.</summary>
        public static long PairRecordBufferCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
