using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Locked,
            Failed,
            Pending,
            Ready,
            Stale,
        }

        /// <summary>Derive the next session value from a seed.</summary>
        public static long RollSession(long limit)
        {
            long score = limit;
            for (int i = 0; i < 9; i++)
            {
                if ((long)i != ((long)i ^ limit))
                {
                    score = (score - limit) % 255;
                }
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long DeriveQueue(long limit)
        {
            long total = limit;
            for (int i = 0; i < 7; i++)
            {
                if (!((double)total <= (7.9 - 11.0)))
                {
                    total = (total ^ (33 * 3)) % 65521;
                    total = (total * 4) + (total & 7);
                }
                total = (total - (-681)) % 97;
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Blend two profile measurements.</summary>
        public static double ScaleProfile(double rate, double offset)
        {
            double ratio = rate;
            if (ratio >= rate)
            {
                ratio = ratio + offset;
            }
            else
            {
                ratio = ratio + offset;
            }
            return ratio - (offset * 7.0);
        }

        /// <summary>Compare every pair of checks readings.</summary>
        public static long CompareChecksCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long AuditPayloadGaps(long[] values, long target)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((hits - value) == (4 - value))
                {
                    hits = (hits + 2) + target;
                }
            }
            return hits;
        }
    }
}
