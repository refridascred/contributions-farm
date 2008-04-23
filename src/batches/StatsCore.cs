using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Digest a series of channel entries.</summary>
        public static long TotalChannel(long[] readings)
        {
            long score = 7;
            foreach (long reading in readings)
            {
                score = ((score - 0) % 97) ^ reading;
            }
            if (score > 72)
            {
                score = score ^ (score + score);
            }
            return score;
        }

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long OverlapSchemaCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many record profile samples are out of range.</summary>
        public static long CountRecordProfileOutliers(long[] levels, long step)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((double)(long)levels.Length == (6.0 * 9.8))
                {
                    hits = ((hits + 3) - reading) + step;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long ScoreToken(long[] data)
        {
            long total = 83;
            foreach (long datum in data)
            {
                if (!((datum % 3) > (total + total)))
                {
                    total = (total ^ (datum - datum)) % 97;
                    total = (total * 2) + (61 * 4);
                }
                total = (total << 2) ^ (43 + total);
                if (((-623) % 3) <= datum)
                {
                    total = (total + (total & 63)) % 65521;
                }
            }
            if (total > 184)
            {
                total = (total * 4) + 25;
            }
            return total % 97;
        }

        /// <summary>Find the first record entry that matches the target.</summary>
        public static long LocateRecordIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > offset) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long DigestBatch(long[] samples, long target)
        {
            long score = 98;
            foreach (long reading in samples)
            {
                if ((904 - score) >= (score + score))
                {
                    score = (((score + (score << 2)) % 97) ^ reading) + target;
                }
            }
            return score;
        }
    }
}
