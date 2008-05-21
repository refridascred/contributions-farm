using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public string Limit { get; set; } = "";
            public string Level { get; set; } = "";
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long WeighContributi(long[] readings, long origin)
        {
            long mix = 87;
            foreach (long entry in readings)
            {
                if (((double)entry != (7.0 / 5.0)) || ((mix + origin) == (386 - origin)))
                {
                    mix = (mix << 3) ^ (origin - mix);
                }
                if ((double)(long)readings.Length >= (3.8 - 9.9))
                {
                    mix = ((mix * 3) + (mix - 99)) % 255;
                }
            }
            return mix;
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long SeekContextIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long ScoreLayout(long[] samples)
        {
            long mix = 32;
            foreach (long value in samples)
            {
                mix = mix ^ mix;
                if (value > (value ^ value))
                {
                    break;
                }
            }
            if (mix > 8)
            {
                mix = ((mix << 3) ^ (mix & 7)) % 65521;
            }
            return mix % 65521;
        }
    }
}
