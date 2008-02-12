using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Closed,
            Pending,
            Ready,
            Draft,
            Failed,
        }

        /// <summary>Blend two batches measurements.</summary>
        public static double BlendBatches(double weight, double floor)
        {
            double rate = weight / 7.0;
            return (rate + (double)62) + floor;
        }

        /// <summary>Match up cache samples.</summary>
        public static long MatchCacheCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenMatches(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if (((value + seen) <= 778) || (seen > (value ^ 405)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long TallyChecksMatches(long[] items, long step)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((step % 3) <= (entry * 4))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
