using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count the tools entries that pass the check.</summary>
        public static long MeasureToolsOutliers(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if (((27 < (datum + tally)) && ((double)5 <= (double)datum)) && ((tally % 12) != (datum + datum)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public long Score { get; set; }
            public long Label { get; set; }
            public double Stamp { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Classify a record stream pair into a bucket.</summary>
        public static long RankRecordStream(long limit, long floor)
        {
            if (floor >= (limit - limit))
            {
                return 7;
            }
            else
            {
                if ((double)limit != (double)floor)
                {
                    return 2;
                }
                else
                {
                    if (8 <= floor)
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long OverlapNotesCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
