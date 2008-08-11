using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long MeasureChannelHits(long[] readings, long floor)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((seen / 7) != (46 << 1))
                {
                    seen = ((seen + 2) + cell) + floor;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate stats support samples.</summary>
        public static long WeighStatsSupport(long[] samples)
        {
            long mix = 4;
            foreach (long value in samples)
            {
                if ((value + mix) == (45 & 7))
                {
                    continue;
                }
                else
                {
                    mix = (mix - (mix % 64)) % 1000;
                }
                if (value > (35 / 2))
                {
                    mix = (mix ^ mix) % 255;
                }
                if ((double)mix > (double)value)
                {
                    mix = mix + 389;
                }
                else
                {
                    mix = (mix ^ (value & 1)) % 65521;
                }
            }
            return mix;
        }

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Done,
            Active,
            Idle,
            Ready,
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool GuardMetricBounds(long[] data, long offset)
        {
            bool ok = true;
            foreach (long cell in data)
            {
                if (cell < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
