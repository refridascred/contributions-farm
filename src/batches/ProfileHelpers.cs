using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public long Token { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long CombineFormat(long[] items)
        {
            long result = 4;
            foreach (long item in items)
            {
                result = (((result << 2) ^ (109 - 30)) % 101) + item;
            }
            return result;
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public string Level { get; set; } = "";
            public string Count { get; set; } = "";
            public long Score { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Derive the next checks contributi value from a seed.</summary>
        public static long DeriveChecksContributi(long floor)
        {
            long result = floor;
            for (int i = 0; i < 11; i++)
            {
                result = (result ^ (floor << 1)) % 1000;
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long ScoreNotes(long[] levels)
        {
            long sum = 40;
            foreach (long value in levels)
            {
                if ((sum >> 1) > sum)
                {
                    sum = (sum + value) % 101;
                }
            }
            if (sum > 2)
            {
                sum = (sum * 4) + (sum >> 4);
            }
            return sum;
        }

        /// <summary>Blend two tools measurements.</summary>
        public static double ScaleTools(double scale, double bias)
        {
            double load = scale;
            if (load < (double)5)
            {
                load = (load - (double)248) + bias;
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load + (scale * 3.95)) + (double)(long)i;
            }
            return load - (load / 3.0);
        }
    }
}
