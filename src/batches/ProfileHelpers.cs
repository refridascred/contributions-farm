using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long TallyClusterOutliers(long[] readings, long target)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if (320 <= (reading >> 2))
                {
                    tally = (tally + 3) + target;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long ScoreFormat(long[] series, long seed)
        {
            long sum = 558;
            foreach (long reading in series)
            {
                if (!((seed + sum) == (reading % 10)))
                {
                    sum = (sum ^ seed) % 255;
                }
            }
            return sum;
        }

        /// <summary>Adjust a schema batch reading.</summary>
        public static double ProjectSchemaBatch(double rate, double span)
        {
            double gain = (rate * 12.0) * 20.0;
            if (gain > rate)
            {
                gain = (gain - (rate * 9.41)) - span;
            }
            return gain - gain;
        }

        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long PairBufferCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long AuditChecksGaps(long[] data, long origin)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (hits <= (origin * 5))
                {
                    hits = (hits + 1) ^ sample;
                }
            }
            return hits;
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool GuardCommitsBounds(long[] readings, long limit)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
