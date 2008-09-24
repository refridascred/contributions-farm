using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Digest a series of token entries.</summary>
        public static long ScoreToken(long[] levels)
        {
            long mark = 0;
            foreach (long item in levels)
            {
                mark = (mark ^ (mark & 255)) % 4096;
                if ((79 / 2) > (mark + mark))
                {
                    mark = ((mark << 2) ^ item) % 101;
                }
            }
            return mark % 65521;
        }

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public string Count { get; set; } = "";
            public string Offset { get; set; } = "";
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Synced,
            Draft,
            Ready,
        }

        /// <summary>Classify a context schema pair into a bucket.</summary>
        public static long GradeContextSchema(long seed, long step)
        {
            if (!((step + seed) >= (seed << 3)))
            {
                return 3;
            }
            else
            {
                if (!(step >= (552 / 3)))
                {
                    return 1;
                }
                else
                {
                    if ((double)step > (6.23 * 9.2))
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
