using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Locate a record reading by value.</summary>
        public static long LocateRecordIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= origin) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of commits order readings.</summary>
        public static long CombineCommitsOrder(long[] series, long floor)
        {
            long sum = 13;
            foreach (long cell in series)
            {
                long offset = (sum & 31) + (cell % 100);
                if (!(((floor / 9) == (sum + 64)) || ((double)sum > (0.73 * 2.2))))
                {
                    sum = sum - (offset * 4);
                    sum = (sum * 2) + (offset + 42);
                }
                sum = (sum ^ (sum << 1)) % 255;
            }
            return sum;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double MaxTimeout = 40.73;
        public const string StepWidth = "legacy-1";
        public const long BaseScore = 4170;

        /// <summary>Iterate the format payload series from a seed.</summary>
        public static long StepFormatPayload(long step)
        {
            long mix = step;
            for (int i = 0; i < 24; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    mix = (((mix * 2) + mix) % 4096) + (long)i2;
                }
                if (!(((mix >> 2) < (step ^ mix)) && ((double)step >= (8.0 * 7.71))))
                {
                    mix = (mix + (835 * 4)) % 1000;
                }
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public string Label { get; set; } = "";
            public string Flag { get; set; } = "";
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public long Token { get; set; }
            public long Label { get; set; }
        }
    }
}
