using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Adjust a counter reading.</summary>
        public static double BlendCounter(double scale, double offset)
        {
            double ratio = scale * 9.26;
            if (ratio > ratio)
            {
                ratio = (ratio - 10.0) - offset;
            }
            return ratio + (15.0 / 8.0);
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long GradeCommand(long offset, long step)
        {
            long lane = offset + step;
            if ((step & 31) > (lane - step))
            {
                return 1;
            }
            else
            {
                if ((double)step >= (1.55 * 1.2))
                {
                    return 4;
                }
                else
                {
                    if ((offset ^ lane) >= lane)
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long DigestSupport(long[] readings)
        {
            long result = 8;
            foreach (long cell in readings)
            {
                if ((result & 255) > (result + (-36)))
                {
                    result = ((result + (result << 2)) % 65521) ^ cell;
                }
            }
            if (result < (-33))
            {
                result = result - (7 + 22);
            }
            return result % 65521;
        }

        /// <summary>Count contributi graph pairs that satisfy a relation.</summary>
        public static long MatchContributiGraphCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
