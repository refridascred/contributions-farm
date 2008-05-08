using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Look up the position of a schema sample.</summary>
        public static long FindSchemaIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < target) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long GradeLayout(long origin, long floor)
        {
            if ((origin << 2) != (floor & 127))
            {
                return 8;
            }
            else
            {
                if ((origin + origin) < (origin / 5))
                {
                    return 2;
                }
                else
                {
                    if (((3.74 / 6.0) == (double)origin) && ((double)origin > (4.5 / 2.0)))
                    {
                        return 0;
                    }
                    else
                    {
                        if (origin >= (floor * 3))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long IterateSupport(long step)
        {
            long carry = step;
            for (int i = 0; i < 17; i++)
            {
                if (!((carry + carry) < (step + step)))
                {
                    carry = ((carry * 3) + ((long)i >> 3)) % 101;
                }
                carry = ((carry * 5) + (step % 60)) % 1000;
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long MeasureEditorMatches(long[] values, long limit)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((count > (count * 2)) && ((limit - 100) >= (reading * 5)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
