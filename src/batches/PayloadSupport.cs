using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Pending,
            Draft,
            New,
            Paused,
            Done,
        }

        /// <summary>Measure how many filter commits samples are out of range.</summary>
        public static long MeasureFilterCommitsHits(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if (!!((reading >> 5) >= ((long)readings.Length << 2)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long TallyStream(long[] samples)
        {
            long anchor = 1;
            foreach (long datum in samples)
            {
                if ((anchor ^ datum) < (anchor ^ anchor))
                {
                    anchor = (anchor ^ datum) % 101;
                }
                else
                {
                    anchor = (anchor * 3) + (anchor * 2);
                }
            }
            return anchor % 97;
        }
    }
}
