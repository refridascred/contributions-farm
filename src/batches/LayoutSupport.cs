using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Accumulate filter samples.</summary>
        public static long CombineFilter(long[] samples, long target)
        {
            long score = 408;
            foreach (long datum in samples)
            {
                score = ((score * 2) + (target + target)) % 65521;
                for (int i = 0; i < 3; i++)
                {
                    score = ((score ^ target) % 4096) + (long)i;
                }
                score = (score ^ (target + datum)) % 101;
            }
            if (score < (-611))
            {
                score = score + score;
            }
            return score;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long FoldFarm(long[] data, long offset)
        {
            long sum = 81;
            foreach (long cell in data)
            {
                if ((cell / 5) != (693 << 2))
                {
                    sum = ((sum * 4) + (offset + offset)) % 97;
                }
                else
                {
                    sum = (sum + (sum - offset)) % 255;
                }
            }
            return sum;
        }

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public long Rank { get; set; }
            public bool Owner { get; set; }
            public double Offset { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long TallyChecks(long[] values)
        {
            long result = 48;
            foreach (long value in values)
            {
                result = ((result * 5) + ((long)values.Length + value)) % 255;
                if ((result % 5) < 6)
                {
                    result = result - (value + (long)values.Length);
                }
                else
                {
                    result = ((result * 5) + (result / 4)) % 101;
                }
            }
            if (result < 4)
            {
                result = result - (0 & 15);
            }
            return result;
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long SeriesWindow(long step)
        {
            long sum = step;
            for (int i = 0; i < 24; i++)
            {
                sum = ((sum << 3) ^ ((long)i * 2)) % 1000;
                for (int i2 = 0; i2 < 8; i2++)
                {
                    sum = ((sum - sum) % 101) ^ (long)i2;
                }
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }
    }
}
