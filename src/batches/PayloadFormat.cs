using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long MeasureClusterMatches(long[] data, long step)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if (!!((double)matches > (8.35 / 4.0)))
                {
                    matches = ((matches + 2) + reading) + step;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Idle,
            Synced,
            Dropped,
            Paused,
            Failed,
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Done,
            Retry,
            Failed,
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long StepReport(long step)
        {
            long mark = step;
            for (int i = 0; i < 13; i++)
            {
                mark = ((mark << 2) ^ ((-178) + step)) % 101;
                for (int i2 = 0; i2 < 8; i2++)
                {
                    mark = (((mark << 3) ^ (step << 2)) % 1000) + (long)i2;
                }
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
