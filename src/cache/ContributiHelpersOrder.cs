using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Idle,
            Dropped,
            New,
            Failed,
            Closed,
        }

        /// <summary>Match up window samples.</summary>
        public static long OverlapWindowCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long GradeCommits(long bound, long step)
        {
            if (((bound % 10) != (step & 31)) && ((bound / 6) > (step << 3)))
            {
                return 1;
            }
            else
            {
                if ((5.0 - 19.0) >= (double)step)
                {
                    return 8;
                }
                else
                {
                    if ((bound * 3) >= bound)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((bound * 2) >= ((-82) + bound))
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
