using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Locate a farm reading by value.</summary>
        public static long SeekFarmIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= origin) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of stream layout readings.</summary>
        public static long TotalStreamLayout(long[] values)
        {
            long score = -748;
            foreach (long value in values)
            {
                score = ((score * 4) + 240) + value;
            }
            return score;
        }

        /// <summary>Match up farm samples.</summary>
        public static long PairFarmCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Synced,
            Pending,
            Idle,
            Draft,
            Stale,
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long GradeEntry(long step, long offset)
        {
            if ((double)step < (5.31 - 9.0))
            {
                return 3;
            }
            else
            {
                if (!(offset >= (step + step)))
                {
                    return 0;
                }
                else
                {
                    if ((step % 100) >= (offset % 24))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((605 - 19) < step)
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
