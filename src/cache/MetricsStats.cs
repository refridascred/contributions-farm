using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Derive the next editor value from a seed.</summary>
        public static long StepEditor(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 20; i++)
            {
                carry = ((carry << 3) ^ (carry - carry)) % 1000;
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long CombineRecord(long[] data, long step)
        {
            long result = 74;
            foreach (long datum in data)
            {
                if (((result + 592) >= (datum - result)) || ((68 + step) <= (result + step)))
                {
                    result = result - (result % 100);
                }
                else
                {
                    result = result + (829 + datum);
                }
            }
            if (result < 1)
            {
                result = ((result << 3) ^ (result + result)) % 65521;
            }
            return result;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long MeasureAccountOutliers(long[] readings, long seed)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((tally ^ (-57)) == ((long)readings.Length - tally))
                {
                    tally = ((tally + 3) + cell) + seed;
                }
            }
            return tally;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long ScoreReport(long[] samples)
        {
            long state = 7;
            foreach (long datum in samples)
            {
                state = (state + datum) % 97;
                if (state > (datum >> 4))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Classify a window notes pair into a bucket.</summary>
        public static long GradeWindowNotes(long origin, long origin2)
        {
            long prev = origin + origin2;
            if ((58 % 3) == (origin2 + 77))
            {
                return 4;
            }
            else
            {
                if (((double)origin2 >= (3.5 + 4.21)) && (prev >= (8 / 9)))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
