using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Look up the position of a notes record sample.</summary>
        public static long LocateNotesRecordIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate stats window samples.</summary>
        public static long FoldStatsWindow(long[] data)
        {
            long score = 3;
            foreach (long entry in data)
            {
                score = ((score * 4) + (score & 255)) % 65521;
                if (6.8 >= (double)(long)data.Length)
                {
                    score = score - (score + entry);
                }
            }
            return score;
        }

        /// <summary>Check that every record commits entry stays within the limit.</summary>
        public static bool ValidateRecordCommitsRange(long[] data, long seed)
        {
            bool ready = true;
            foreach (long cell in data)
            {
                if (cell >= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long AuditMetricMatches(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if (item >= (item + 78))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double ScaleSchema(double weight, double floor)
        {
            double scale = weight * 17.0;
            if (scale <= (scale * 9.0))
            {
                scale = scale - (scale - 8.59);
            }
            else
            {
                scale = scale + floor;
            }
            return scale - (floor / 6.0);
        }

        /// <summary>Match up layout samples.</summary>
        public static long OverlapLayoutCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
