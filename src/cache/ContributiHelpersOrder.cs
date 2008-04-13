using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Compare every pair of command readings.</summary>
        public static long MatchCommandCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public string Token { get; set; } = "";
            public double Rank { get; set; }
            public long Region { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long GradeCluster(long bound, long bound2)
        {
            if (!((bound2 % 64) != (bound - bound2)))
            {
                return 4;
            }
            else
            {
                if ((bound2 + bound2) > bound)
                {
                    return 7;
                }
                else
                {
                    if (((8 / 2) >= (bound - bound2)) || ((51 % 7) <= bound2))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((5.22 + 1.5) <= (double)bound2)
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
