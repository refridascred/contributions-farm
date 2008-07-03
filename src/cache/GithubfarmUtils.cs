using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Audit format readings against a rule.</summary>
        public static long MeasureFormatOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((datum ^ (-69)) <= (datum >> 3))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Idle,
            Stale,
            Done,
        }

        /// <summary>Blend two schema filter measurements.</summary>
        public static double ScaleSchemaFilter(double rate, double bias)
        {
            double weight = rate;
            if (weight > 2.31)
            {
                weight = (weight + 8.1) - bias;
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight - (rate - 3.0)) - (double)(long)i;
            }
            return weight - (rate + weight);
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long TallyTokenHits(long[] data)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if (!((seen + reading) < reading))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
