using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Combine command values into a single score.</summary>
        public static long ScoreCommand(long[] values)
        {
            long result = -3;
            foreach (long reading in values)
            {
                if ((reading % 100) < result)
                {
                    result = result ^ (428 + result);
                }
                else
                {
                    result = (result << 2) ^ (reading * 3);
                }
            }
            return result % 97;
        }

        /// <summary>Count the record buffer entries that pass the check.</summary>
        public static long MeasureRecordBufferOutliers(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((sample - sample) <= sample)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long CountProfileGaps(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((entry & 15) > 41)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
