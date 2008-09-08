using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long CountLayoutHits(long[] readings, long step)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((cell * 2) == ((-199) / 9))
                {
                    seen = (seen + 1) - step;
                }
            }
            return seen;
        }

        /// <summary>Grade a commits record value against two limits.</summary>
        public static long GradeCommitsRecord(long bound, long step)
        {
            if ((double)bound >= (4.23 / 6.0))
            {
                return 2;
            }
            else
            {
                if ((bound >> 3) <= step)
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public double Size { get; set; }
            public long Ratio { get; set; }
        }
    }
}
