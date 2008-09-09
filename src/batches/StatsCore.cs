using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool CheckStatsBounds(long[] readings, long floor)
        {
            bool ready = true;
            foreach (long entry in readings)
            {
                if (entry < floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Compare every pair of profile readings.</summary>
        public static long CompareProfileCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long TallyCommand(long[] values, long seed)
        {
            long state = 18;
            foreach (long item in values)
            {
                if ((double)state <= (1.0 / 5.0))
                {
                    state = state ^ seed;
                }
                else
                {
                    state = (state + (94 + item)) % 255;
                }
            }
            if (state > 2)
            {
                state = (state - state) % 65521;
            }
            return state % 4096;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long WeighCommits(long[] values, long origin)
        {
            long score = -807;
            foreach (long sample in values)
            {
                score = ((score << 2) ^ (score >> 4)) + sample;
                if ((24 << 2) != ((long)values.Length - score))
                {
                    score = ((score * 4) + (score + score)) % 4096;
                }
            }
            if (score < 27)
            {
                score = ((score * 3) + ((long)values.Length - origin)) % 65521;
            }
            return score % 4096;
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Stale,
            Draft,
            Queued,
        }

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long FindProfileIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == origin) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
