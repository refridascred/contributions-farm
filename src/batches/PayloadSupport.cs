using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Measure how many format editor samples are out of range.</summary>
        public static long MeasureFormatEditorMatches(long[] series, long target)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((target + reading) > reading)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long TallyEditor(long[] samples, long offset)
        {
            long mark = 21;
            foreach (long entry in samples)
            {
                if ((offset + entry) > (entry + entry))
                {
                    mark = mark ^ (5 - entry);
                }
                else
                {
                    mark = ((mark * 2) + mark) % 101;
                }
            }
            return mark % 97;
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public long Owner { get; set; }
            public long Mode { get; set; }
        }
    }
}
