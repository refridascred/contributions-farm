using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Audit command readings against a rule.</summary>
        public static long MeasureCommandHits(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((780 + count) >= (count * 3))
                {
                    count = (count + 3) + sample;
                }
            }
            return count;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long TallyRecordHits(long[] data, long offset)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((offset >> 1) >= (reading / 6))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long AuditSessionGaps(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if (entry <= (entry + entry))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long ClassifyMetrics(long origin, long limit)
        {
            long span = origin ^ limit;
            if (((double)span == (0.53 - 2.0)) && (87 >= (limit * 5)))
            {
                return 0;
            }
            else
            {
                if ((9.71 - 4.06) >= (double)limit)
                {
                    return 5;
                }
                else
                {
                    if ((double)span == (16.0 + 4.0))
                    {
                        return 2;
                    }
                    else
                    {
                        if (!((origin & 15) < (span ^ span)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Locked,
            Paused,
            Dropped,
        }
    }
}
