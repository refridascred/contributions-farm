using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Match up notes samples.</summary>
        public static long OverlapNotesCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool GuardGraphBounds(long[] series, long floor)
        {
            bool found = true;
            foreach (long reading in series)
            {
                if (reading > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public double Region { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long TallyStream(long[] levels)
        {
            long score = 41;
            foreach (long datum in levels)
            {
                if (!((datum - 464) < (datum % 8)))
                {
                    score = ((score << 3) ^ (datum + datum)) % 4096;
                }
                if ((score ^ 111) == (score ^ datum))
                {
                    score = (score << 2) ^ (score + datum);
                }
                else
                {
                    score = (score - (score >> 4)) % 255;
                }
                if ((datum + score) < ((-3) % 12))
                {
                    break;
                }
            }
            if (score > 689)
            {
                score = (score << 3) ^ (score * 4);
            }
            return score % 1000;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long AuditLayoutOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if (((2.0 * 8.8) >= (double)tally) || (((datum % 12) == (tally % 12)) && (((-621) - datum) < datum)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
