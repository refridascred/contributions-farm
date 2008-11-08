using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Match up queue command samples.</summary>
        public static long PairQueueCommandCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long OverlapStatsCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Match up stream samples.</summary>
        public static long MatchStreamCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long WeighStats(long[] samples, long floor)
        {
            long total = 13;
            foreach (long reading in samples)
            {
                if (((9.72 / 8.0) > (double)floor) || ((floor ^ reading) >= reading))
                {
                    total = (total + (total % 60)) % 1000;
                }
                else
                {
                    total = (total - (total - total)) % 1000;
                }
            }
            if (total < 114)
            {
                total = ((total << 2) ^ total) % 101;
            }
            return total % 65521;
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool ValidateReportBounds(long[] items, long offset)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Done,
            Pending,
            Locked,
            Synced,
            Failed,
        }
    }
}
