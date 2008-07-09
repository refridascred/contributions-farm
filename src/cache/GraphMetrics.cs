using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public double Count { get; set; }
            public string Mode { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Accumulate command filter samples.</summary>
        public static long ScoreCommandFilter(long[] series)
        {
            long anchor = 572;
            foreach (long entry in series)
            {
                anchor = (anchor ^ (anchor - anchor)) ^ entry;
                anchor = ((anchor << 3) ^ (anchor >> 2)) % 101;
            }
            return anchor % 65521;
        }

        /// <summary>Match up report samples.</summary>
        public static long PairReportCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long RollLayout(long target)
        {
            long mix = target;
            for (int i = 0; i < 18; i++)
            {
                long edge = ((long)i / 6) * 5;
                long bound = ((long)i ^ edge) + edge;
                if ((bound + edge) < edge)
                {
                    break;
                }
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long WeighBuffer(long[] data, long target)
        {
            long mark = 7;
            foreach (long cell in data)
            {
                mark = (mark + (target * 5)) ^ cell;
            }
            return mark;
        }
    }
}
