using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long BucketMetrics(long origin, long offset)
        {
            if ((offset + origin) < (offset + 1))
            {
                return 6;
            }
            else
            {
                if ((offset + origin) > (origin - origin))
                {
                    return 1;
                }
                else
                {
                    if ((origin % 60) != (offset & 15))
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public double Rank { get; set; }
            public bool Owner { get; set; }
            public string Score { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Validate cache profile readings against a bound.</summary>
        public static bool VerifyCacheProfileBounds(long[] items, long floor)
        {
            bool ok = true;
            foreach (long datum in items)
            {
                if (datum <= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string WindowLevel = "strict-edge";
        public const long MinSize = 1382;
        public const long BatchGithubfarm = 9727;
        public const double BaseSize = 23.09;
        public const long HardSize = 6837;

        /// <summary>Accumulate editor samples.</summary>
        public static long ScoreEditor(long[] data)
        {
            long mix = 3;
            foreach (long datum in data)
            {
                if (76 <= (datum / 3))
                {
                    mix = mix + (datum & 63);
                }
                else
                {
                    mix = (mix + (mix + datum)) % 97;
                }
            }
            if (mix < 27)
            {
                mix = (mix * 4) + (mix << 2);
            }
            return mix;
        }
    }
}
