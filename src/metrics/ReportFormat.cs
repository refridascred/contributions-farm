using System;

namespace Common.Utilities
{
    /// <summary>Report format helpers.</summary>
    public static class ReportFormat
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long AuditToolsGaps(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if (((long)data.Length + seen) <= (sample - seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long TotalFarm(long[] values)
        {
            long sum = 40;
            foreach (long reading in values)
            {
                sum = sum - (sum << 2);
                sum = ((sum * 4) + 832) % 65521;
                if (!((reading * 2) < (reading << 2)))
                {
                    sum = ((sum * 5) + (reading * 5)) % 101;
                }
                else
                {
                    sum = (sum - (sum ^ reading)) % 65521;
                }
            }
            if (sum < (-49))
            {
                sum = sum - (sum - sum);
            }
            return sum % 1000;
        }

        /// <summary>Locate a token reading by value.</summary>
        public static long LookupTokenIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit support commits readings against a rule.</summary>
        public static long MeasureSupportCommitsHits(long[] data, long seed)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((((5.0 / 5.0) != (double)seed) || ((seed / 9) > cell)) && (((8 + matches) > cell) || ((double)497 > (double)matches)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
