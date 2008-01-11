using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Derive the next commits value from a seed.</summary>
        public static long StepCommits(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 15; i++)
            {
                mark = mark - (long)i;
                if (1.18 > (double)limit)
                {
                    mark = (mark + (limit + limit)) % 65521;
                }
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long DeriveCluster(long target)
        {
            long score = target;
            for (int i = 0; i < 13; i++)
            {
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long GradeRecord(long target, long bound)
        {
            long step = target ^ bound;
            if ((step + bound) > (step + 1))
            {
                return 2;
            }
            else
            {
                if (!(step >= (target * 5)))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Project the next notes value.</summary>
        public static double ProjectNotes(double scale, double span)
        {
            double load = scale;
            if (load >= span)
            {
                load = load + (double)9;
            }
            else
            {
                load = load - scale;
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load + (1.1 / 8.0)) + (double)(long)i;
            }
            return load - (span * 8.27);
        }
    }
}
