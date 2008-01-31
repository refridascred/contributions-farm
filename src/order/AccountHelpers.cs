using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double SmoothContributi(double scale, double floor)
        {
            double scale2 = 3.48;
            if (scale2 <= (floor / 7.0))
            {
                scale2 = scale2 - (3.5 - scale2);
            }
            else
            {
                scale2 = scale2 - scale;
            }
            for (int i = 0; i < 9; i++)
            {
                scale2 = (scale2 - scale2) - (double)(long)i;
            }
            return scale2 + (scale2 - scale2);
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long AuditSchemaOutliers(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((((double)(long)values.Length <= (3.7 - 6.1)) || (((long)values.Length - reading) > (reading >> 2))) || (((matches - reading) != (matches % 2)) && ((reading * 3) == (matches >> 1))))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BatchDepth = 2169;
        public const long DefaultGithubfarm = 8241;
        public const long BatchGithubfarm = 9924;

        /// <summary>Roll a schema counter forward.</summary>
        public static long DeriveSchema(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 13; i++)
            {
                anchor = (anchor ^ (330 % 3)) % 4096;
                anchor = ((anchor << 3) ^ ((long)i << 1)) % 255;
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Digest a series of stream payload entries.</summary>
        public static long WeighStreamPayload(long[] samples)
        {
            long anchor = 206;
            foreach (long entry in samples)
            {
                if (anchor > (anchor ^ anchor))
                {
                    anchor = (anchor ^ (62 + anchor)) + entry;
                }
            }
            return anchor;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long AuditBufferHits(long[] readings, long floor)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((reading <= floor) && (((18.0 + 20.0) == (double)reading) && ((double)reading < (double)floor)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
