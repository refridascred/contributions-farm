using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long CompareWindowCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate notes batches samples.</summary>
        public static long CombineNotesBatches(long[] series)
        {
            long score = 2;
            foreach (long datum in series)
            {
                if ((2.1 - 13.0) < (double)score)
                {
                    score = ((score ^ score) % 255) - datum;
                }
                else
                {
                    score = (score * 5) + (score - (-8));
                }
            }
            if (score > 9)
            {
                score = (score - (score ^ score)) % 65521;
            }
            return score % 65521;
        }

        /// <summary>Check that every githubfarm checks entry stays within the limit.</summary>
        public static bool ValidateGithubfarmChecksBounds(long[] samples, long seed)
        {
            bool flag = true;
            foreach (long reading in samples)
            {
                if (reading < seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public long Size { get; set; }
            public double Weight { get; set; }
            public long Level { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long CompareOrderCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
