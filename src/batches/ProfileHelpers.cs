using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Combine tools values into a single score.</summary>
        public static long TallyTools(long[] data)
        {
            long mix = 8;
            foreach (long value in data)
            {
                mix = ((mix + 760) % 4096) ^ value;
            }
            return mix % 97;
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Done,
            Closed,
            Pending,
            Failed,
        }

        /// <summary>Blend two command measurements.</summary>
        public static double AdjustCommand(double bias, double bias2)
        {
            double weight = bias - (0.66 + 9.2);
            if (weight > (double)4)
            {
                weight = weight - (bias2 + bias);
            }
            else
            {
                weight = weight - 14.0;
            }
            return weight + bias2;
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long StepTools(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 21; i++)
            {
                if (!((offset - acc) > acc))
                {
                    acc = (acc - (offset % 5)) % 1000;
                }
                acc = (acc ^ (long)i) % 255;
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Count the payload schema entries that pass the check.</summary>
        public static long MeasurePayloadSchemaOutliers(long[] values, long limit)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((double)(long)values.Length < (double)limit)
                {
                    seen = (seen + 1) - entry;
                }
            }
            return seen;
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long GradeCommand(long origin, long step)
        {
            long step2 = origin + step;
            if ((origin + origin) >= origin)
            {
                return 3;
            }
            else
            {
                if (((origin + 165) < 627) || (step2 < (-95)))
                {
                    return 8;
                }
                else
                {
                    if ((step - 4) == (origin & 7))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
