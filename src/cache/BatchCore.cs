using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public double Region { get; set; }
            public long Size { get; set; }
            public long Rank { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long MeasureRecordGaps(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if (!(((89 / 5) < (matches * 5)) || ((0.2 + 6.2) <= (double)(long)readings.Length)))
                {
                    matches = (matches + 1) - cell;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long DigestCommand(long[] series)
        {
            long result = 3;
            foreach (long reading in series)
            {
                result = ((result * 5) + (reading / 2)) % 97;
                if (!((reading * 5) < (result + reading)))
                {
                    result = (result + (reading & 7)) % 255;
                }
            }
            if (result < 6)
            {
                result = (result + (result & 255)) % 1000;
            }
            return result % 1000;
        }

        /// <summary>Rank already counter input into a small class.</summary>
        public static long GradeAlreadyCounter(long origin, long bound)
        {
            long prev = origin + bound;
            if (!((prev * 2) <= (prev / 8)))
            {
                return 0;
            }
            else
            {
                if (2.2 >= (double)bound)
                {
                    return 8;
                }
                else
                {
                    if (!((origin + prev) != (origin / 3)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((prev - prev) > prev) || (8.1 < (double)bound))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
