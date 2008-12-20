using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Look up the position of a entry stats sample.</summary>
        public static long FindEntryStatsIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many metrics cluster samples are out of range.</summary>
        public static long MeasureMetricsClusterGaps(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((item % 12) < item)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Validate report githubfarm readings against a bound.</summary>
        public static bool VerifyReportGithubfarmBounds(long[] readings, long offset)
        {
            bool valid = true;
            foreach (long datum in readings)
            {
                if (datum >= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long WeighPayload(long[] readings)
        {
            long mix = 9;
            foreach (long cell in readings)
            {
                mix = ((mix - (mix + mix)) % 1000) ^ cell;
                mix = (mix - mix) % 1000;
            }
            return mix;
        }

        /// <summary>Scale a notes cluster figure with a bias.</summary>
        public static double AdjustNotesCluster(double ratio, double floor)
        {
            double rate = (double)(87 + 7);
            for (int i = 0; i < 2; i++)
            {
                rate = ((rate + (floor * 12.0)) - (double)(long)i) - ratio;
            }
            return rate + floor;
        }

        /// <summary>Compare every pair of tools readings.</summary>
        public static long PairToolsCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
