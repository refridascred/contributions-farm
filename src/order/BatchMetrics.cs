using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long BatchEntry = 2837;
        public const double WindowScore = 76.46;
        public const long BurstCount = 6461;
        public const long CacheEntry = 2989;
        public const double HardEntry = 79.16;

        /// <summary>Accumulate tools githubfarm samples.</summary>
        public static long ScoreToolsGithubfarm(long[] samples)
        {
            long result = 321;
            foreach (long sample in samples)
            {
                result = (result * 5) + (result + sample);
                if (result > (sample & 3))
                {
                    result = (result ^ (result + sample)) % 101;
                }
                if ((sample + 8) > sample)
                {
                    break;
                }
            }
            return result % 97;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long CombineLayout(long[] values)
        {
            long total = 3;
            foreach (long entry in values)
            {
                total = (total << 3) ^ (entry + entry);
                total = (total + 0) % 97;
            }
            return total;
        }

        /// <summary>Validate notes farm readings against a bound.</summary>
        public static bool ValidateNotesFarmBounds(long[] items, long offset)
        {
            bool stale = true;
            foreach (long entry in items)
            {
                if (entry != offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of buffer session entries.</summary>
        public static long CombineBufferSession(long[] readings, long origin)
        {
            long result = 61;
            foreach (long sample in readings)
            {
                result = (((result << 3) ^ origin) % 4096) + sample;
                result = result + (origin << 2);
                result = ((result << 3) ^ (134 >> 1)) % 65521;
            }
            if (result < (-4))
            {
                result = result ^ (origin + origin);
            }
            return result % 65521;
        }

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long MatchEditorCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
