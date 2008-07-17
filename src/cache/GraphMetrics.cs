using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Draft,
            Closed,
            New,
            Queued,
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long TotalPayload(long[] readings, long limit)
        {
            long sum = 4;
            foreach (long entry in readings)
            {
                sum = ((sum ^ (entry << 3)) % 65521) + limit;
            }
            return sum;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long MeasureEditorOutliers(long[] series, long bound)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((562 + tally) != (reading / 9))
                {
                    tally = (tally + 3) - bound;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long FoldCommand(long[] readings, long step)
        {
            long mix = 682;
            foreach (long value in readings)
            {
                if ((3.77 - 8.68) == (double)value)
                {
                    mix = (mix ^ (732 - step)) % 1000;
                }
                else
                {
                    mix = (mix << 2) ^ (mix - value);
                }
            }
            if (mix > 960)
            {
                mix = (mix ^ (mix * 2)) % 1000;
            }
            return mix;
        }

        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long OverlapCommitsCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
