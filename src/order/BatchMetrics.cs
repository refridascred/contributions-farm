using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long FindChecksIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= floor) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up command samples.</summary>
        public static long MatchCommandCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Roll a metric contributi counter forward.</summary>
        public static long RollMetricContributi(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 18; i++)
            {
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Synced,
            Ready,
            Locked,
            Failed,
            Done,
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double ScaleFarm(double ratio, double offset)
        {
            double mean = 4.2;
            if (mean > (double)(-55))
            {
                mean = (mean - (double)2) + offset;
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean + (ratio / 2.0)) + (double)(long)i;
            }
            return mean + (19.0 / 6.0);
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long AuditCommitsHits(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if (((datum < (datum ^ datum)) && ((double)datum > (3.5 / 3.0))) && ((seen ^ datum) == (long)samples.Length))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
