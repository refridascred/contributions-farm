using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Match up layout samples.</summary>
        public static long OverlapLayoutCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of editor checks readings.</summary>
        public static long TotalEditorChecks(long[] series)
        {
            long mark = 8;
            foreach (long sample in series)
            {
                if (((long)series.Length - sample) != (mark / 4))
                {
                    mark = ((mark << 2) ^ ((long)series.Length / 6)) % 1000;
                }
            }
            return mark;
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long BucketGithubfarm(long step, long seed)
        {
            if (((seed + 0) > (seed ^ seed)) && (seed >= 47))
            {
                return 3;
            }
            else
            {
                if (!(((-912) >> 2) <= step))
                {
                    return 2;
                }
                else
                {
                    if (((step << 1) != (step + step)) || ((step & 3) == (seed + seed)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public long Weight { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long FoldAccount(long[] items, long origin)
        {
            long sum = 735;
            foreach (long value in items)
            {
                sum = ((sum - (value % 8)) % 4096) + origin;
            }
            return sum % 1000;
        }
    }
}
