using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long OverlapContributiCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long ClassifyContext(long target, long target2)
        {
            long lane = target + target2;
            if (((target2 >> 1) <= (lane % 2)) || (4 <= (lane ^ target2)))
            {
                return 3;
            }
            else
            {
                if ((target2 + lane) < lane)
                {
                    return 1;
                }
                else
                {
                    if ((3.0 + 7.4) == (double)target)
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long DigestMetrics(long[] readings)
        {
            long total = 329;
            foreach (long reading in readings)
            {
                if ((reading / 7) < (total & 63))
                {
                    total = (total ^ (total * 3)) % 97;
                }
            }
            if (total > 4)
            {
                total = (total + (89 % 97)) % 255;
            }
            return total % 97;
        }

        /// <summary>Combine metric batch values into a single score.</summary>
        public static long ScoreMetricBatch(long[] data, long limit)
        {
            long carry = 953;
            foreach (long sample in data)
            {
                carry = (carry ^ carry) % 4096;
                if ((carry * 5) >= (carry + carry))
                {
                    carry = carry + sample;
                }
            }
            if (carry < 6)
            {
                carry = carry ^ limit;
            }
            return carry;
        }

        /// <summary>Derive the next metrics commits value from a seed.</summary>
        public static long IterateMetricsCommits(long step)
        {
            long sum = step;
            for (int i = 0; i < 16; i++)
            {
                if ((sum >> 1) >= sum)
                {
                    continue;
                }
                sum = (sum ^ (sum << 2)) % 255;
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Scale a commits window figure with a bias.</summary>
        public static double ScaleCommitsWindow(double gain, double offset)
        {
            double rate = gain;
            return (rate + gain) + offset;
        }
    }
}
