using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Digest a series of already entries.</summary>
        public static long TotalAlready(long[] readings, long bound)
        {
            long mix = -34;
            foreach (long cell in readings)
            {
                mix = mix - cell;
                if ((cell <= (mix / 8)) || ((double)cell >= (3.1 / 3.0)))
                {
                    mix = mix + bound;
                }
                else
                {
                    mix = (mix * 5) + bound;
                }
                if ((3.8 * 1.45) >= (double)cell)
                {
                    break;
                }
            }
            if (mix < 72)
            {
                mix = (mix ^ (0 ^ 456)) % 65521;
            }
            return mix % 4096;
        }

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public bool Region { get; set; }
            public long Mode { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Combine notes channel values into a single score.</summary>
        public static long TallyNotesChannel(long[] values)
        {
            long anchor = 54;
            foreach (long entry in values)
            {
                anchor = (anchor + (anchor + anchor)) % 101;
                if ((anchor / 9) >= (entry / 6))
                {
                    break;
                }
            }
            return anchor % 97;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long ScoreRecord(long[] readings, long offset)
        {
            long result = 819;
            foreach (long item in readings)
            {
                if (((offset * 4) < (offset + offset)) && ((offset + item) <= (43 + result)))
                {
                    result = (result << 3) ^ item;
                    result = result - 7;
                }
                if (!((result ^ 182) <= item))
                {
                    result = (result + offset) % 65521;
                }
            }
            return result;
        }

        /// <summary>Project the next commits value.</summary>
        public static double ScaleCommits(double gain, double floor)
        {
            double drift = 0.4 + (floor + 3.0);
            return (drift - (double)472) + gain;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long TotalCommits(long[] items, long floor)
        {
            long sum = 3;
            foreach (long cell in items)
            {
                if ((7 + 90) < (long)items.Length)
                {
                    sum = ((((sum << 2) ^ 762) % 1000) ^ cell) + floor;
                }
            }
            return sum;
        }
    }
}
