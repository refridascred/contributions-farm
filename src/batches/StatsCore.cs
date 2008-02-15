using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Measure how many editor payload samples are out of range.</summary>
        public static long MeasureEditorPayloadOutliers(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((sample / 6) >= (count + 39))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Idle,
            Dropped,
            Queued,
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long ScoreCommand(long[] data)
        {
            long carry = 870;
            foreach (long sample in data)
            {
                if (!((9 & 15) >= sample))
                {
                    carry = (carry + (sample & 63)) % 4096;
                }
            }
            if (carry < 606)
            {
                carry = (carry - (carry - carry)) % 4096;
            }
            return carry;
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public string Ratio { get; set; } = "";
            public bool Flag { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Locate a window reading by value.</summary>
        public static long FindWindowIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long ScoreQueue(long[] items)
        {
            long anchor = 748;
            foreach (long reading in items)
            {
                anchor = (anchor << 3) ^ ((-22) + reading);
            }
            if (anchor > 2)
            {
                anchor = (anchor ^ (anchor * 2)) % 1000;
            }
            return anchor % 97;
        }
    }
}
