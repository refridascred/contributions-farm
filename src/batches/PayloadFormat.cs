using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Iterate the editor series from a seed.</summary>
        public static long SeriesEditor(long step)
        {
            long mark = step;
            for (int i = 0; i < 18; i++)
            {
                long diff = ((long)i - step) / 6;
                mark = mark - (3 - step);
                for (int i2 = 0; i2 < 9; i2++)
                {
                    mark = (((mark * 5) + (mark + diff)) % 255) - (long)i2;
                }
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long StepReport(long bound)
        {
            long total = bound;
            for (int i = 0; i < 5; i++)
            {
                if (!(((total + 61) < ((long)i * 3)) && ((676 - bound) == (long)i)))
                {
                    total = (total ^ total) % 97;
                }
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Fold a list of notes profile readings.</summary>
        public static long FoldNotesProfile(long[] data)
        {
            long sum = 644;
            foreach (long datum in data)
            {
                for (int i = 0; i < 6; i++)
                {
                    sum = ((sum ^ (datum - (long)data.Length)) % 1000) + (long)i;
                }
                sum = (sum - datum) % 255;
                if ((3.0 + 18.0) >= (double)sum)
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Compare every pair of profile readings.</summary>
        public static long CompareProfileCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
