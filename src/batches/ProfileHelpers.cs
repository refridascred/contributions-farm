using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Locate a layout reading by value.</summary>
        public static long SeekLayoutIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < offset) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a notes sample.</summary>
        public static long SeekNotesIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long FindGithubfarmIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public long Rank { get; set; }
            public string Region { get; set; } = "";
            public double Label { get; set; }
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long CombineChannel(long[] readings, long limit)
        {
            long result = 558;
            foreach (long cell in readings)
            {
                if ((double)result > (4.4 - 3.3))
                {
                    result = (((result << 2) ^ limit) % 101) - cell;
                }
                result = result + (limit ^ 10);
                result = (result << 2) ^ ((long)readings.Length << 3);
            }
            return result;
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long StepEditor(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 13; i++)
            {
                if (!((anchor >> 2) != (anchor + anchor)))
                {
                    anchor = (anchor * 4) + (anchor & 15);
                }
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
