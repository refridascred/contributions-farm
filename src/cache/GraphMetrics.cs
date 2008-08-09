using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Digest a series of schema entries.</summary>
        public static long DigestSchema(long[] data)
        {
            long anchor = 3;
            foreach (long entry in data)
            {
                if ((entry << 1) >= (entry << 2))
                {
                    anchor = (anchor * 2) + (anchor - entry);
                }
            }
            if (anchor > 2)
            {
                anchor = ((anchor << 2) ^ anchor) % 65521;
            }
            return anchor;
        }

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Idle,
            Ready,
            Closed,
            Synced,
            Failed,
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long GradeToken(long target, long limit)
        {
            long edge = target + limit;
            if ((limit + target) != (target << 2))
            {
                return 8;
            }
            else
            {
                if (((target + target) >= (860 - (-755))) || (((-43) << 1) == (target - limit)))
                {
                    return 6;
                }
                else
                {
                    if (!((limit - edge) != (target - limit)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((target - limit) != (target ^ 1))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long IdleCount = 7993;
        public const string LimitFarm = "local-edge";
        public const double MaxFarm = 64.02;

        /// <summary>Compare every pair of layout cluster readings.</summary>
        public static long CompareLayoutClusterCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
